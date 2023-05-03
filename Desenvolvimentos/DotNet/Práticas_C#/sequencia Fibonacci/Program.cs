
        
            int penutimoValor = 1;
            int ultimoValor = 2;
            int valorAtual;
            int somaPares = 2;

            while (penutimoValor + ultimoValor < 4000000)
            {
                valorAtual = penutimoValor + ultimoValor;
                penutimoValor = ultimoValor;
                ultimoValor = valorAtual;

                if (valorAtual % 2 == 0)
                {
                    somaPares += valorAtual;
                }
            } 

            Console.WriteLine("Soma pares " + somaPares);
        
