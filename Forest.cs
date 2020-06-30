using System;


namespace ForestLife
{
    public enum Distribution { Random, Manual};

    public class Forest
    {
        // we consider cyclic boundaies
        public double p; // probabilty that a white space can be green
        public byte[,] cells;  // cells=0 (empty)   cells=1 (green)   cells=2 (fired)
        byte[,] cellsOld;
        public int L, H;
        public int steps = 0;
        public int n_Fired, n_Green;
        public bool cyclicX, cyclicY;
        Random rand = new Random();
        int[] nX = { 1, 0, -1, 0 };
        int[] nY = { 0, 1, 0, -1 };



        public Forest(int L, int H, bool cyclicX, bool cyclicY)
        {
            this.cyclicX = cyclicX;
            this.cyclicY = cyclicY;
            this.L = L;
            this.H = H;
            cells = new byte[L, H];
            cellsOld = new byte[L, H];
            InitRandmoly();
        }
        public Forest(int L, int H, int n_Fired, int n_Green, bool cyclicX, bool cyclicY)
        {
            this.cyclicX = cyclicX;
            this.cyclicY = cyclicY;
            this.L = L;
            this.H = H;
            cells = new byte[L, H];
            cellsOld = new byte[L, H];
            this.n_Fired = n_Fired;
            this.n_Green = n_Green;
            InitManually();
        }

        void InitRandmoly()
        {
            double r;
            for (int i = 0; i < L; i++)
                for (int j = 0; j < H; j++)
                {
                    r = rand.NextDouble();
                    if (r < 0.3333333333)
                    {
                        cells[i, j] = 1;
                        n_Green++;
                    }
                    else if (r < 0.66666666666)
                    {
                        cells[i, j] = 2;
                        n_Fired++;
                    }
                }
                    

        }

        void InitManually()
        {
            int i, j, n;
            for (n = 0; n < n_Green; )
            {
                i = rand.Next(L);
                j = rand.Next(H);
                if (cells[i, j] == 0)
                {
                    cells[i, j] = 1;
                    n++;
                }
            }

            for (n = 0; n < n_Fired; )
            {
                i = rand.Next(L);
                j = rand.Next(H);
                if (cells[i, j] == 0)
                {
                    cells[i, j] = 2;
                    n++;
                }
            }

        }


        public void NextStep(double p)
        {
            steps++;

            this.p = p;
            int i, j;
            for (i = 0; i < L; i++)
                for (j = 0; j < H; j++)
                    cellsOld[i, j] = cells[i, j];

            byte temp;
            for (i = 0; i < L; i++)
                for (j = 0; j < H; j++)
                {
                    temp = cellsOld[i, j];
                    if (temp == 2)
                    {
                        cells[i, j] = 0;
                        n_Fired--;
                    }
                    else if (temp == 1)
                    {
                        if (IsNeighbourBurning(i, j))
                        {
                            cells[i, j] = 2;
                            n_Green--;
                            n_Fired++;
                        }
                    }
                    else // temp == 0
                    {
                        if (rand.NextDouble() < p)
                        {
                            cells[i, j] = 1;
                            n_Green++;
                        }
                    }
                }
        
            

        }

        bool IsNeighbourBurning(int x, int y)
        {
            int xNew, yNew;
            for (int i = 0; i < 4; i++)
            {
                if (cyclicX) 
                    xNew = PBC(x + nX[i], L);
                else
                {
                    xNew = x + nX[i];
                    if (xNew < 0 || xNew > L - 1) continue;
                }
                if (cyclicY)
                    yNew = PBC(y + nY[i], H);
                else
                {
                    yNew = y + nY[i];
                    if (yNew < 0 || yNew > H - 1) continue;
                }

                if (cellsOld[xNew, yNew] == 2) return true;
            }
            return false;
        }

        int PBC(int i, int upBound)
        {
            if (i >= upBound) return 0;
            else if (i < 0) return upBound - 1;
            else return i;

        }

    }
}
