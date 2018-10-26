using System;
namespace quadrado
{
    public class Quadrado
    {
        private int LadoA;
        private int LadoB;
        private int LadoC;
        private int LadoD;

        public void defineValorLadoA( int valorLadoA){
            LadoA = valorLadoA;
        }

        public int getvalorLadoA (){
            return LadoA;
        }

        public void defineValorLadoB(int valorLadoB)
        {
            LadoB = valorLadoB;
        }

        public int getvalorLadoB()
        {
            return LadoB;
        }

        public void defineValorLadoC(int valorLadoC)
        {
            LadoC = valorLadoC;
        }

        public int getvalorLadoC()
        {
            return LadoC;
        }

        public void defineValorLadoD(int valorLadoD)
        {
            LadoD = valorLadoD;
        }

        public int getvalorLadoD()
        {
            return LadoD;
        }

        public Quadrado()
        {
        }
    }
}
