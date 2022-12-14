using Lab3.FileSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using File = Lab3.FileSystem.File;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using System.Xml;

namespace Lab3.FilesMerger
{
    static public class Merger
    {
        static public void Merge(File main, File merged)
        {
            HtmlDocument mainDoc = GetHtmlDocument(main);
            HtmlDocument mergedDoc = GetHtmlDocument(merged);

            MoveFiles(main, merged, mergedDoc);

            HtmlDocument result = new HtmlDocument();
            result.DocumentNode.InnerHtml = MergeHead(mainDoc, mergedDoc);
            result.DocumentNode.InnerHtml += MergeBody(mainDoc, mergedDoc);

            System.IO.File.WriteAllText(main.Path, result.DocumentNode.OuterHtml);
        }

        static private HtmlDocument GetHtmlDocument(File file)
        {
            var doc = new HtmlDocument();
            doc.Load(file.Path);
            return doc;
        }

        static private void MoveFiles(File mainFile, File mergedFile, HtmlDocument mergedDocument)
        {
            Folder mainFolder = mainFile.Folder;
            
            var images = mergedDocument.DocumentNode.Descendants("img");
            if (images == null)
                return;

            HashSet<string> paths = new HashSet<string>(); 
            foreach (var image in images)
            {
                string? src = image.GetAttributeValue("src", null);
                if (src == null)
                    continue;
                if(!src.StartsWith("http") && !src.StartsWith("//"))
                    paths.Add(src);
            }

            foreach (var image in images)
            {
                string? src = image.GetAttributeValue("src", null);
                if (paths.Contains(src))
                {
                    File file;
                    try
                    {
                        file = new File(src);
                        file.Move(System.IO.Path.Combine(mainFolder.Path, "moved_" + file.Name));
                    }
                    catch { continue; }
                    image.SetAttributeValue("src", file.Path);
                }
            }   

            return;
        }

        static private string MergeHead(HtmlDocument main, HtmlDocument merged)
        {
            HtmlNode? mainHead = main.DocumentNode.SelectSingleNode("//head");
            HtmlNode? mergedHead = merged.DocumentNode.SelectSingleNode("//head");

            if (mainHead == null && mergedHead == null)
                return "";
            if (mainHead == null && mergedHead != null)
                return mergedHead.OuterHtml;
            if (mainHead != null && mergedHead == null)
                return mainHead.OuterHtml;
            mainHead.InnerHtml += mergedHead.InnerHtml;
            return mainHead.OuterHtml;
        }

        static private string MergeBody(HtmlDocument main, HtmlDocument merged)
        {
            HtmlNode? mainBody = main.DocumentNode.SelectSingleNode("//head");
            HtmlNode? mergedBody = merged.DocumentNode.SelectSingleNode("//head");

            if (mainBody == null && mergedBody == null)
                return "";
            if (mainBody == null && mergedBody != null)
                return mergedBody.OuterHtml;
            if (mainBody != null && mergedBody == null)
                return mainBody.OuterHtml;
            mainBody.InnerHtml += mergedBody.InnerHtml;
            return mainBody.OuterHtml;
        }
    }
}
