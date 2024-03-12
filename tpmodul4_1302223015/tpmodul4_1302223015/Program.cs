namespace tpmodul4_1302223015
{
    public class KodePos
    {
        public enum Kelurahan {Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja }
        public static int getKodePos(Kelurahan kelurahan)
        {
            int[] kodepos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            return kodepos[(int) kelurahan];
        }
    }
    public class DoorMachine
    {
        public enum State { Terkunci, Terbuka }
        State state = State.Terkunci;

        public void ShowDisplay()
        {
            if (state == State.Terkunci)
            {
                Console.WriteLine("Pintu Terkunci");
            }
            else
            {
                Console.WriteLine("Pintu Tidak Terkunci");
            }
        }

        public void ChangeState(State newState)
        {
            state = newState;
        }
        
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KodePos.getKodePos(KodePos.Kelurahan.Batununggal));
            DoorMachine doorMachine = new DoorMachine();
            doorMachine.ShowDisplay();
            doorMachine.ChangeState(DoorMachine.State.Terbuka);
            doorMachine.ShowDisplay();

        }
    }
}
