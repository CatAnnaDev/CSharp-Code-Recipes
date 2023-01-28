using System;
namespace GuideCSharp.Universialdynamictypes.InteractionwithCOM
{
	public class InteractionWithCOM
	{
		public InteractionWithCOM()
		{
            //Create simple Excel table
            var excelType = Type.GetTypeFromProgID("Excel.Application");
            dynamic excel = Activator.CreateInstance(excelType);
            excel.workbooks.Add();
            dynamic worksheet = excel.ActiveSheet;

            worksheet.Cells[1, 1] = 3;
            worksheet.Cells[2, 1] = 5;
            worksheet.Cells[3, 1] = "=sum(R[-2]C[0]:R[-1]C[0])";

            excel.Visible = true;
        }
	}
}

