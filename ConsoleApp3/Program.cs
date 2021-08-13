using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Amiga
    {
        // private로 선언되어 있다.
        private int release;
        private string pcName;

        // 하지만 프로퍼티로 선언하면 다른 클래스에서도 접근할수 있다
        public int Release { get { return release; } set { release = value; } }
        public string PC_Name { get { return pcName; } set { pcName = value; } }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Amiga oldAmiga = new Amiga();
            Amiga newAmiga = new Amiga();

            // newAmiga.release = 1982; << private 변수인 release는 여기서 접근할수 없다..

            // 하지만 방법이 있다.
            // release, pcName 변수가 private로 선언되어 있어도, 
            // 프로퍼티 덕분에 여기서도 접근할수 있다.

            newAmiga.Release = 1992; 
            newAmiga.PC_Name = "Amiga 92";

            oldAmiga.Release = 1972;
            oldAmiga.PC_Name = "Amiga 72";

            Console.WriteLine(newAmiga.PC_Name +"는 " + newAmiga.Release +"년 출시한 컴퓨터");
            Console.WriteLine(oldAmiga.PC_Name + "는 " + oldAmiga.Release + "년 출시한 컴퓨터");
        }
    }
}
