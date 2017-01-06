using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace DUBStats
{
    class PdfCreator
    {
        public const string DestinationFile = "c:/temp/pdfua.pdf";
          /**
         * Creates an accessible PDF with images and text.
         * @param dest  the path to the resulting PDF
         * @throws IOException
         * @throws DocumentException 
         */
        public static void CreatePdf(String content)
        {
            Document document = new Document(PageSize.A4.Rotate());
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(DestinationFile, FileMode.CreateNew));
            PdfName version =  new PdfName("7");
            writer.SetPdfVersion(version);
            //TAGGED PDF
            //Make document tagged
            writer.SetTagged();
            //===============
            //PDF/UA
            //Set document metadata
            writer.ViewerPreferences = PdfWriter.DisplayDocTitle;
            document.AddLanguage("en-US");
            document.AddTitle("English pangram");
            writer.CreateXmpMetadata();
            //=====================
            document.Open();
 
            Paragraph p = new Paragraph();
            //PDF/UA
            //Embed font
            //Font font = FontFactory.GetFont(FONT, BaseFont.WINANSI, BaseFont.EMBEDDED, 20);
            Font font = FontFactory.GetFont("C:/Windows/Fonts/arial.ttf", BaseFont.WINANSI, BaseFont.EMBEDDED, 20);
            p.Font = font;
            //==================
            Chunk c = new Chunk("The quick brown ");
            p.Add(c);
            //Image i = Image.GetInstance(FOX);
            //c = new Chunk(i, 0, -24);
            //PDF/UA
            //Set alt text
            c.SetAccessibleAttribute(PdfName.ALT, new PdfString("Fox"));
            //==============
            p.Add(c);
            p.Add(new Chunk(" jumps over the lazy "));
            //i = Image.getInstance(DOG);
            //c = new Chunk(i, 0, -24);
            //PDF/UA
            //Set alt text
            c.SetAccessibleAttribute(PdfName.ALT, new PdfString("Dog"));
            //==================
            p.Add(c);
            document.Add(p);
 
            p = new Paragraph("\n\n\n\n\n\n\n\n\n\n\n\n", font);
            document.Add(p);
            List list = new List(true);
            list.Add(new ListItem("quick", font));
            list.Add(new ListItem("brown", font));
            list.Add(new ListItem("fox", font));
            list.Add(new ListItem("jumps", font));
            list.Add(new ListItem("over", font));
            list.Add(new ListItem("the", font));
            list.Add(new ListItem("lazy", font));
            list.Add(new ListItem("dog", font));
            document.Add(list);
            Paragraph result = new Paragraph {content};
            document.Add(result);
            document.Close();
        }
    }
}
