using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace DUBStats
{
    class PdfCreator
    {
          /**
         * Creates an accessible PDF with images and text.
         * @param dest  the path to the resulting PDF
         * @throws IOException
         * @throws DocumentException 
         */
        public static void CreatePdf(Dictionary<string, Dictionary<int, int>> content, String outputFile, String projectName)
        {
            Document document = new Document(PageSize.A4.Rotate());

            try
            {
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outputFile,
                    File.Exists(outputFile) ? FileMode.Open : FileMode.CreateNew));
                PdfName version = new PdfName("7");
                writer.SetPdfVersion(version);
                //TAGGED PDF
                //Make document tagged
                writer.SetTagged();
                //===============
                //PDF/UA
                //Set document metadata
                writer.ViewerPreferences = PdfWriter.DisplayDocTitle;
                document.AddLanguage("en-US");
                document.AddTitle("Casting Stats & Loops: " + projectName);
                writer.CreateXmpMetadata();
                //=====================
                document.Open();

                Paragraph p = new Paragraph();
                //PDF/UA
                //Embed font
                //Font font = FontFactory.GetFont(FONT, BaseFont.WINANSI, BaseFont.EMBEDDED, 20);
                Font font = FontFactory.GetFont("C:/Windows/Fonts/arialbd.ttf", BaseFont.WINANSI, BaseFont.EMBEDDED, 20f);
                p.Font = font;
                //==================
                Chunk c = new Chunk("Bright Way – Casting Stats & Loops");
                p.Alignment = Element.ALIGN_CENTER;
                p.Add(c);
                //Image i = Image.GetInstance(FOX);
                //c = new Chunk(i, 0, -24);
                //PDF/UA
                //Set alt text
                //c.SetAccessibleAttribute(PdfName.ALT, new PdfString("Fox"));
                //==============
                //p.Add(c);
                document.Add(p);

                p = new Paragraph("\n", font);
                document.Add(p);

                PdfPTable table = new PdfPTable(2);
                float[] widths = { 1f, 2f };
                table.SetWidths(widths);

                var cellFilmTitle = new PdfPCell(new Phrase("PROJETO: " + projectName,
                        FontFactory.GetFont("C:/Windows/Fonts/arialbd.ttf", BaseFont.WINANSI,
                            BaseFont.EMBEDDED, 12f, Font.BOLD, BaseColor.WHITE)))
                {
                    BackgroundColor = BaseColor.LIGHT_GRAY,
                    Colspan = 2,
                    HorizontalAlignment = 1, //0=Left, 1=Centre, 2=Right
                    PaddingBottom = 5f,
                    PaddingLeft = 20f,
                    PaddingTop = 4f
                };
                table.AddCell(cellFilmTitle);

                var cellActor = new PdfPCell(new Phrase("ATOR/ATRIZ",
                        FontFactory.GetFont("C:/Windows/Fonts/arialbd.ttf", BaseFont.WINANSI,
                            BaseFont.EMBEDDED, 12f, Font.BOLD, BaseColor.WHITE)))
                {
                    BackgroundColor = BaseColor.ORANGE,
                    HorizontalAlignment = 1, //0=Left, 1=Centre, 2=Right
                    PaddingBottom = 10f,
                    PaddingLeft = 20f,
                    PaddingTop = 4f
                };
                table.AddCell(cellActor);

                var cellCharacter = new PdfPCell(new Phrase("PERSONAGEM/LOOPS",
                        FontFactory.GetFont("C:/Windows/Fonts/arialbd.ttf", BaseFont.WINANSI,
                            BaseFont.EMBEDDED, 12f, Font.BOLD, BaseColor.WHITE)))
                {
                    BackgroundColor = BaseColor.ORANGE,
                    HorizontalAlignment = 1, //0=Left, 1=Centre, 2=Right
                    PaddingBottom = 10f,
                    PaddingLeft = 20f,
                    PaddingTop = 4f
                };
                table.AddCell(cellCharacter);

                foreach (var outerKeyValuePair in content)
                {
                    table.AddCell(String.Empty);
                    var result = new StringBuilder();
                    var count = 0;
                    result.AppendLine(outerKeyValuePair.Key + ": " + content[outerKeyValuePair.Key].Keys.Count + " loops.");
                    foreach (var innerKeyValuePair in content[outerKeyValuePair.Key])
                    {
                        if (count == content[outerKeyValuePair.Key].Keys.Count)
                        {
                            result.AppendLine(innerKeyValuePair.Key + ".");
                        }
                        else
                        {
                            result.Append(innerKeyValuePair.Key + ", ");
                        }
                        count++;
                    }
                    var paragraph = new Paragraph(result.ToString(0, result.Length),
                        FontFactory.GetFont("C:/Windows/Fonts/arial.ttf", BaseFont.WINANSI,
                            BaseFont.EMBEDDED, 12f, Font.NORMAL, BaseColor.BLACK));
                    paragraph.SetLeading(25f, 0);
                    var cellLoops = new PdfPCell(paragraph)
                    {
                        PaddingBottom = 10f,
                        PaddingLeft = 20f,
                        PaddingTop = 4f
                    };
                    table.AddCell(cellLoops);
                }
                document.Add(table);
                document.Close();
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show(@"The document cannot be saved because it is being used by another process. Please make sure that the document is closed in your machine and try again.",
                    @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
