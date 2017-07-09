using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.IO;
using System.Data.OleDb;
using System.Data;

namespace WebApplication1.BOT
{
    public partial class BulkUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_OnClick(object sender, EventArgs e)
        {
            this.ExcelRead3();
        }

        private void ExcelRead2()
        {
            try
            {
                //specify the file name where its actually exist   
                string filepath = @"C:\File\rawfile.xlsx";

                //open the excel using openxml sdk  
                using (SpreadsheetDocument doc = SpreadsheetDocument.Open(filepath, false))
                {

                    //create the object for workbook part  
                    WorkbookPart wbPart = doc.WorkbookPart;

                    //statement to get the count of the worksheet  
                    int worksheetcount = doc.WorkbookPart.Workbook.Sheets.Count();

                    //statement to get the sheet object  
                    Sheet mysheet = (Sheet)doc.WorkbookPart.Workbook.Sheets.ChildElements.GetItem(0);

                    //statement to get the worksheet object by using the sheet id  
                    Worksheet Worksheet = ((WorksheetPart)wbPart.GetPartById(mysheet.Id)).Worksheet;

                    //Note: worksheet has 8 children and the first child[1] = sheetviewdimension,....child[4]=sheetdata  
                    int wkschildno = 4;


                    //statement to get the sheetdata which contains the rows and cell in table  
                    SheetData Rows = (SheetData)Worksheet.ChildElements.GetItem(wkschildno);


                    //getting the row as per the specified index of getitem method  
                    Row currentrow = (Row)Rows.ChildElements.GetItem(1);

                    //getting the cell as per the specified index of getitem method  
                    Cell currentcell = (Cell)currentrow.ChildElements.GetItem(1);

                    //statement to take the integer value  
                    string currentcellvalue = currentcell.InnerText;

                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        private void ExcelRead1()
        {
            string fileName = @"C:\File\rawfile.xlsx";

            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (SpreadsheetDocument doc = SpreadsheetDocument.Open(fs, false))
                {
                    WorkbookPart workbookPart = doc.WorkbookPart;
                    SharedStringTablePart sstpart = workbookPart.GetPartsOfType<SharedStringTablePart>().First();
                    SharedStringTable sst = sstpart.SharedStringTable;

                    WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                    Worksheet sheet = worksheetPart.Worksheet;

                    var cells = sheet.Descendants<Cell>();
                    var rows = sheet.Descendants<Row>();

                    Console.WriteLine("Row count = {0}", rows.LongCount());
                    Console.WriteLine("Cell count = {0}", cells.LongCount());

                    // One way: go through each cell in the sheet
                    foreach (Cell cell in cells)
                    {
                        if ((cell.DataType != null) && (cell.DataType == CellValues.SharedString))
                        {
                            int ssid = int.Parse(cell.CellValue.Text);
                            string str = sst.ChildElements[ssid].InnerText;
                            Console.WriteLine("Shared string {0}: {1}", ssid, str);
                        }
                        else if (cell.CellValue != null)
                        {
                            Console.WriteLine("Cell contents: {0}", cell.CellValue.Text);
                        }
                    }

                    // Or... via each row
                    foreach (Row row in rows)
                    {
                        foreach (Cell c in row.Elements<Cell>())
                        {
                            if ((c.DataType != null) && (c.DataType == CellValues.SharedString))
                            {
                                int ssid = int.Parse(c.CellValue.Text);
                                string str = sst.ChildElements[ssid].InnerText;
                                Console.WriteLine("Shared string {0}: {1}", ssid, str);
                            }
                            else if (c.CellValue != null)
                            {
                                Console.WriteLine("Cell contents: {0}", c.CellValue.Text);
                            }
                        }
                    }
                }
            }
        }

        private void ExcelRead3()
        {
            var fileName = @"C:\File\rawfile.xlsx";
            var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 12.0;IMEX=1;HDR=NO;TypeGuessRows=0;ImportMixedTypes=Text\""; ;
            using (var conn = new OleDbConnection(connectionString))
            {
                conn.Open();

                var sheets = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM [" + sheets.Rows[0]["TABLE_NAME"].ToString() + "] ";

                    var adapter = new OleDbDataAdapter(cmd);
                    var ds = new DataSet();
                    adapter.Fill(ds);
                }
            }
        }
    }
}