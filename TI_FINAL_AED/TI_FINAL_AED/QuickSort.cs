namespace TI_FINAL_AED
{
    class QuickSort
    {
            public static Multas[] quickSort(Multas[] vetor)
            {
                int inicio = 0;
                int fim = vetor.Length - 1;
                quickSort(vetor, inicio, fim);

                return vetor;
            }

            private static void quickSort(Multas[] vetor, int inicio, int fim)
            {
                if (inicio < fim)
                {
                    Multas p = vetor[inicio];
                    int i = inicio + 1;
                    int f = fim;
                    while (i <= f)
                    {
                        if (vetor[i].dataEmissao <= p.dataEmissao)
                        {
                            i++;
                        }
                        else if (p.dataEmissao < vetor[f].dataEmissao)
                        {
                            f--;
                        }
                        else
                        {
                            Multas troca = vetor[i];
                            vetor[i] = vetor[f];
                            vetor[f] = troca;
                            i++;
                            f--;
                        }
                    }
                    vetor[inicio] = vetor[f];
                    vetor[f] = p;
                    quickSort(vetor, inicio, f - 1);
                    quickSort(vetor, f + 1, fim);
                }
            }
        }
    }