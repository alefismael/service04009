using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using Wp = DocumentFormat.OpenXml.Wordprocessing;

namespace Service04009
{
    /// <summary>
    /// Utilitário para geração de documentos Word (.docx) via OpenXml SDK.
    /// </summary>
    internal static class WordHelper
    {
        public static Wp.Paragraph Paragraph(string text, bool bold = false, string fontSize = "20",
            Wp.JustificationValues? align = null, string? color = null)
        {
            var rp = new Wp.RunProperties();
            rp.Append(new Wp.RunFonts { Ascii = "Segoe UI", HighAnsi = "Segoe UI" });
            rp.Append(new Wp.FontSize { Val = fontSize });
            if (bold) rp.Append(new Wp.Bold());
            if (color != null) rp.Append(new Wp.Color { Val = color });

            var para = new Wp.Paragraph();
            if (align.HasValue)
                para.Append(new Wp.ParagraphProperties(new Wp.Justification { Val = align.Value }));
            para.Append(new Wp.Run(rp, new Wp.Text(text) { Space = SpaceProcessingModeValues.Preserve }));
            return para;
        }

        public static Wp.TableCell Cell(string text, bool bold = false, string fontSize = "18")
        {
            var cell = new Wp.TableCell();
            var rp = new Wp.RunProperties();
            rp.Append(new Wp.RunFonts { Ascii = "Segoe UI", HighAnsi = "Segoe UI" });
            rp.Append(new Wp.FontSize { Val = fontSize });
            if (bold) rp.Append(new Wp.Bold());
            cell.Append(new Wp.Paragraph(new Wp.Run(rp,
                new Wp.Text(text) { Space = SpaceProcessingModeValues.Preserve })));
            return cell;
        }

        /// <summary>
        /// Cria célula com múltiplos parágrafos (um por linha/atirador).
        /// </summary>
        public static Wp.TableCell MultiLineCell(IEnumerable<string> lines, string fontSize = "18")
        {
            var cell = new Wp.TableCell();
            var list = lines.ToList();
            if (list.Count == 0)
            {
                var rp = new Wp.RunProperties();
                rp.Append(new Wp.RunFonts { Ascii = "Segoe UI", HighAnsi = "Segoe UI" });
                rp.Append(new Wp.FontSize { Val = fontSize });
                cell.Append(new Wp.Paragraph(new Wp.Run(rp, new Wp.Text("—"))));
            }
            else
            {
                foreach (var line in list)
                {
                    var rp = new Wp.RunProperties();
                    rp.Append(new Wp.RunFonts { Ascii = "Segoe UI", HighAnsi = "Segoe UI" });
                    rp.Append(new Wp.FontSize { Val = fontSize });
                    cell.Append(new Wp.Paragraph(new Wp.Run(rp,
                        new Wp.Text(line) { Space = SpaceProcessingModeValues.Preserve })));
                }
            }
            return cell;
        }

        public static Wp.Table CreateTable()
        {
            var tbl = new Wp.Table();
            tbl.Append(new Wp.TableProperties(
                new Wp.TableBorders(
                    new Wp.TopBorder { Val = Wp.BorderValues.Single, Size = 4 },
                    new Wp.BottomBorder { Val = Wp.BorderValues.Single, Size = 4 },
                    new Wp.LeftBorder { Val = Wp.BorderValues.Single, Size = 4 },
                    new Wp.RightBorder { Val = Wp.BorderValues.Single, Size = 4 },
                    new Wp.InsideHorizontalBorder { Val = Wp.BorderValues.Single, Size = 4 },
                    new Wp.InsideVerticalBorder { Val = Wp.BorderValues.Single, Size = 4 }
                ),
                new Wp.TableWidth { Type = Wp.TableWidthUnitValues.Pct, Width = "5000" }
            ));
            return tbl;
        }

        public static Wp.SectionProperties LandscapeA4()
        {
            return new Wp.SectionProperties(
                new Wp.PageSize { Width = 16838U, Height = 11906U, Orient = Wp.PageOrientationValues.Landscape },
                new Wp.PageMargin { Top = 720, Bottom = 720, Left = 720U, Right = 720U }
            );
        }
    }
}
