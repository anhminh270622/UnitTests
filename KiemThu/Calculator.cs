public class Calculator
{
	public long Add(int num1, int num2)
	{
		return num1 + (long)num2;
	}

	public long Subtract(int num1, int num2)
	{
		return num1 - (long)num2;
	}

	public long Multiply(int num1, int num2)
	{
		return num1 * (long)num2;
	}

	public double Divide(int num1, int num2)
	{
		if (num2 == 0)
		{
			throw new ArgumentException("Không thể chia cho 0.");
		}
		return num1 / (double)num2;
	}
}
