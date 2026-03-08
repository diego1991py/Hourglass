namespace Task.Backend
{
    public class Matrix
    {
        private int _order;
        private int[,] _matrix;

        public Matrix(int order)
        {
            Order = order;
            _matrix = new int[Order, Order];
        }

        public int Order
        {
            get => _order;
            set => _order = ValidateOrder(value);
        }

        private int ValidateOrder(int order)
        {
            if (order <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(order),
                    "The order of the matrix cannot be less than 1");
            }

            return order;
        }

        public void FillMatrix()
        {
            for (int i = 0; i < Order; i++)
            {
                for (int j = 0; j < Order; j++)
                {
                    _matrix[i, j] = i + j;
                }
            }
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < Order; i++)
            {
                for (int j = 0; j < Order; j++)
                {
                    Console.Write($"{_matrix[i, j],4}");
                }

                Console.WriteLine();
            }
        }

        public void ShowHourGlass()
        {
            int mid = Order / 2;

            for (int i = 0; i < Order; i++)
            {
                for (int j = 0; j < Order; j++)
                {
                    if (i <= mid)
                    {
                        if (j >= i && j <= Order - i - 1)
                            Console.Write($"{_matrix[i, j],4}");
                        else
                            Console.Write("    ");
                    }
                    else
                    {
                        if (j >= Order - i - 1 && j <= i)
                            Console.Write($"{_matrix[i, j],4}");
                        else
                            Console.Write("    ");
                    }
                }

                Console.WriteLine();
            }
        }

    }
}