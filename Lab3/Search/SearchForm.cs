using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3.Search
{
    public partial class SearchForm : Form
    {
        Search _search;
        string? _queryDisplayed;

        public SearchForm(Search search)
        {
            InitializeComponent();

            _search = search;
            resultsView.CellPainting += CellPainting;

            Text = "Пошук в " + _search.Path;
        }

        private void searchQueryTextBox_TextChanged(object sender, EventArgs e)
        {
            ExecuteQueryAndDisplayResult(searchQueryTextBox.Text);
        }

        private void ExecuteQueryAndDisplayResult(string query)
        {
            resultsView.Rows.Clear();

            IEnumerable<SearchResult> results = _search.Find(query);
            _queryDisplayed = query;
            foreach (SearchResult result in results)
            {
                resultsView.Rows.Add(new object[] { result.Path, result.Header });
            }
        }

        // from stackoverflow -- I don't now how it works))
        private void CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                e.Handled = true;
                e.PaintBackground(e.CellBounds, true);

                string? sw = _queryDisplayed;

                if (!string.IsNullOrEmpty(sw))
                {
                    string val = (string)e.FormattedValue;
                    int sindx = val.ToLower().IndexOf(sw.ToLower());
                    if (sindx >= 0)
                    {
                        Rectangle hl_rect = new Rectangle();
                        hl_rect.Y = e.CellBounds.Y + 2;
                        hl_rect.Height = e.CellBounds.Height - 5;

                        string sBefore = val.Substring(0, sindx);
                        string sWord = val.Substring(sindx, sw.Length);
                        Size s1 = TextRenderer.MeasureText(e.Graphics, sBefore, e.CellStyle.Font, e.CellBounds.Size);
                        Size s2 = TextRenderer.MeasureText(e.Graphics, sWord, e.CellStyle.Font, e.CellBounds.Size);

                        if (s1.Width > 5)
                        {
                            hl_rect.X = e.CellBounds.X + s1.Width - 5;
                            hl_rect.Width = s2.Width - 6;
                        }
                        else
                        {
                            hl_rect.X = e.CellBounds.X + 2;
                            hl_rect.Width = s2.Width - 6;
                        }

                        SolidBrush hl_brush = default(SolidBrush);
                        if (((e.State & DataGridViewElementStates.Selected) != DataGridViewElementStates.None))
                        {
                            hl_brush = new SolidBrush(Color.DarkGoldenrod);
                        }
                        else
                        {
                            hl_brush = new SolidBrush(Color.Yellow);
                        }

                        e.Graphics.FillRectangle(hl_brush, hl_rect);

                        hl_brush.Dispose();
                    }
                }
                e.PaintContent(e.CellBounds);
            }
        }
    }
}
