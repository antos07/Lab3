using Lab3.FileSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace Lab3.Search
{
    public class Search
    {
        private Folder _root;

        public string Path { get { return _root.Path; } }

        public Search(Folder root)
        {
            _root = root;
        }

        public IEnumerable<SearchResult> Find(string query)
        {
            if (string.IsNullOrEmpty(query))
                return Enumerable.Empty<SearchResult>();
            return Explorer(_root, query);
        }

        private IEnumerable<SearchResult> Explorer(Folder folder, string query)
        {
            foreach (FileSystem.File file in folder.SearchFiles("*.html"))
            {
                IEnumerable<SearchResult> results = GetResults(file, query);
                foreach (SearchResult result in results)
                    yield return result;
            }
            foreach (Folder subfolder in folder.Subfolders)
            {
                foreach (SearchResult result in Explorer(subfolder, query))
                    yield return result;
            }
        }

        private IEnumerable<SearchResult> GetResults(FileSystem.File file, string query)
        {
            var doc = new HtmlDocument();
            try
            {
                doc.Load(file.Path);
            }
            catch
            {
                yield break;
            }

            for (int i = 1; i <= 6; i++)
            {
                string tag = "h" + i.ToString();

                var nodes = doc.DocumentNode.SelectNodes("//" + tag);
                if (nodes == null)
                    continue;
                foreach (var node in nodes)
                {
                    if (node.InnerText.Contains(query))
                        yield return new SearchResult { Header = node.OuterHtml, Path = file.Path };
                }
            }
        }
    }
}
