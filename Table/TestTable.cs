using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.Table
{
    public  class TestTable
    {
        public void Main() {
            Random rnd = new Random();
            Table[] tables= new Table[10];
            for (int i = 0; i < 10; i++) {
                tables[i] = new Table(rnd.Next(50, 201), rnd.Next(50, 201));
            }
            foreach (Table table in tables)
            {
                table.ShowData();
            }
        }
    }
}
