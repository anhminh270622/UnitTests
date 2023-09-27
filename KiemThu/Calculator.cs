﻿public class Calculator
{
	public double Add(double num1, double num2)
	{
		return num1 + num2;
	}

	public double Subtract(double num1, double num2)
	{
		return num1 - num2;
	}

	public double Multiply(double num1, double num2)
	{
		return num1 * num2;
	}

	public double Divide(double num1, double num2)
	{
		if (num2 == 0)
		{
			throw new ArgumentException("Không thể chia cho 0.");
		}
		return num1 / num2;
	}
}
