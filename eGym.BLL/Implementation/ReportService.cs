﻿using eGym.DAL;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace eGym.BLL.Implementation;

public class ReportService : IReportService
{
    private readonly IUnitOfWork _unitOfWork;

	public ReportService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
	}

    public async Task<byte[]> GetEmployeeReport()
    {
        var result = await _unitOfWork.Employees.GetAll();

        using (MemoryStream ms = new MemoryStream())
        {
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(document, ms);

            document.Open();

            Paragraph p1 = new Paragraph("Izvjestaj zaposlenih", new Font(Font.FontFamily.TIMES_ROMAN, 20));
            p1.Alignment = Element.ALIGN_CENTER;
            document.Add(p1);

            PdfPTable table = new PdfPTable(5);

            PdfPCell cell1 = new PdfPCell(new Phrase("ID", new Font(Font.FontFamily.TIMES_ROMAN, 10)));
            cell1.HorizontalAlignment = Element.ALIGN_CENTER;
            cell1.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell1);

            PdfPCell cell2 = new PdfPCell(new Phrase("Ime", new Font(Font.FontFamily.TIMES_ROMAN, 10)));
            cell2.HorizontalAlignment = Element.ALIGN_CENTER;
            cell2.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell2);

            PdfPCell cell3 = new PdfPCell(new Phrase("Prezime", new Font(Font.FontFamily.TIMES_ROMAN, 10)));
            cell3.HorizontalAlignment = Element.ALIGN_CENTER;
            cell3.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell3);

            PdfPCell cell4 = new PdfPCell(new Phrase("Username", new Font(Font.FontFamily.TIMES_ROMAN, 10)));
            cell4.HorizontalAlignment = Element.ALIGN_CENTER;
            cell4.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell4);

            PdfPCell cell5 = new PdfPCell(new Phrase("Rola", new Font(Font.FontFamily.TIMES_ROMAN, 10)));
            cell5.HorizontalAlignment = Element.ALIGN_CENTER;
            cell5.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell5);

            foreach(var empolyee in result)
            {
                PdfPCell cell_1 = new PdfPCell(new Phrase(empolyee.EmployeeId.ToString(), new Font(Font.FontFamily.TIMES_ROMAN, 10)));
                cell_1.HorizontalAlignment = Element.ALIGN_CENTER;
                cell_1.VerticalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell_1);

                PdfPCell cell_2 = new PdfPCell(new Phrase(empolyee.FirstName, new Font(Font.FontFamily.TIMES_ROMAN, 10)));
                cell_2.HorizontalAlignment = Element.ALIGN_CENTER;
                cell_2.VerticalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell_2);

                PdfPCell cell_3 = new PdfPCell(new Phrase(empolyee.LastName, new Font(Font.FontFamily.TIMES_ROMAN, 10)));
                cell_3.HorizontalAlignment = Element.ALIGN_CENTER;
                cell_3.VerticalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell_3);

                PdfPCell cell_4 = new PdfPCell(new Phrase(empolyee.Username, new Font(Font.FontFamily.TIMES_ROMAN, 10)));
                cell_4.HorizontalAlignment = Element.ALIGN_CENTER;
                cell_4.VerticalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell_4);

                PdfPCell cell_5 = new PdfPCell(new Phrase(empolyee.Role.ToString(), new Font(Font.FontFamily.TIMES_ROMAN, 10)));
                cell_5.HorizontalAlignment = Element.ALIGN_CENTER;
                cell_5.VerticalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell5);
            }

            document.Add(table);
            document.Close();
            writer.Close();

            return ms.ToArray();
        }
    }

    public async Task<byte[]> GetFinanceReport()
    {
        var result = await _unitOfWork.Payments.GetAll();

        using (MemoryStream ms = new MemoryStream())
        {
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(document, ms);

            document.Open();

            Paragraph p1 = new Paragraph("Izvjestaj zaposlenih", new Font(Font.FontFamily.TIMES_ROMAN, 20));
            p1.Alignment = Element.ALIGN_CENTER;
            document.Add(p1);

            PdfPTable table = new PdfPTable(5);

            PdfPCell cell1 = new PdfPCell(new Phrase("ID", new Font(Font.FontFamily.TIMES_ROMAN, 10)));
            cell1.HorizontalAlignment = Element.ALIGN_CENTER;
            cell1.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell1);

            PdfPCell cell2 = new PdfPCell(new Phrase("Ime", new Font(Font.FontFamily.TIMES_ROMAN, 10)));
            cell2.HorizontalAlignment = Element.ALIGN_CENTER;
            cell2.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell2);

            PdfPCell cell3 = new PdfPCell(new Phrase("Prezime", new Font(Font.FontFamily.TIMES_ROMAN, 10)));
            cell3.HorizontalAlignment = Element.ALIGN_CENTER;
            cell3.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell3);

            PdfPCell cell4 = new PdfPCell(new Phrase("Username", new Font(Font.FontFamily.TIMES_ROMAN, 10)));
            cell4.HorizontalAlignment = Element.ALIGN_CENTER;
            cell4.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell4);

            PdfPCell cell5 = new PdfPCell(new Phrase("Rola", new Font(Font.FontFamily.TIMES_ROMAN, 10)));
            cell5.HorizontalAlignment = Element.ALIGN_CENTER;
            cell5.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell5);

            document.Add(table);
            document.Close();
            writer.Close();

            return ms.ToArray();
        }
    }

    public async Task<byte[]> GetUserReport()
    {
        var result = await _unitOfWork.Accounts.GetAll();

        using (MemoryStream ms = new MemoryStream())
        {
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(document, ms);

            document.Open();

            Paragraph p1 = new Paragraph("Izvjestaj zaposlenih", new Font(Font.FontFamily.TIMES_ROMAN, 20));
            p1.Alignment = Element.ALIGN_CENTER;
            document.Add(p1);

            PdfPTable table = new PdfPTable(5);

            PdfPCell cell1 = new PdfPCell(new Phrase("ID", new Font(Font.FontFamily.TIMES_ROMAN, 10)));
            cell1.HorizontalAlignment = Element.ALIGN_CENTER;
            cell1.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell1);

            PdfPCell cell2 = new PdfPCell(new Phrase("Ime", new Font(Font.FontFamily.TIMES_ROMAN, 10)));
            cell2.HorizontalAlignment = Element.ALIGN_CENTER;
            cell2.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell2);

            PdfPCell cell3 = new PdfPCell(new Phrase("Prezime", new Font(Font.FontFamily.TIMES_ROMAN, 10)));
            cell3.HorizontalAlignment = Element.ALIGN_CENTER;
            cell3.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell3);

            PdfPCell cell4 = new PdfPCell(new Phrase("Username", new Font(Font.FontFamily.TIMES_ROMAN, 10)));
            cell4.HorizontalAlignment = Element.ALIGN_CENTER;
            cell4.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell4);

            PdfPCell cell5 = new PdfPCell(new Phrase("Rola", new Font(Font.FontFamily.TIMES_ROMAN, 10)));
            cell5.HorizontalAlignment = Element.ALIGN_CENTER;
            cell5.VerticalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell5);

            document.Add(table);
            document.Close();
            writer.Close();

            return ms.ToArray();
        }
    }
}

