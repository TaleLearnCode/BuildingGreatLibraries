namespace TaleLearnCode.MathOperationsLibrary
{

	/// <summary>
	/// Provides a series of basic mathematical operations.
	/// </summary>
	/// <inheritdoc cref="IMathOperations"/>
	public class MathOperations : IMathOperations
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

		/// <inheritdoc cref="IMathOperations.Divide(double, double)"/>
		/// <exception cref="MathOperationsException">Thrown when there is an attempt to divide by zero.</exception>
		public double Divide(double num1, double num2)
		{
			if (num2 == 0)
			{
				//throw new DivideByZeroException("Cannot divide by zero);
				throw new MathOperationsException("Cannot divide by zero");
			}
			return num1 / num2;
		}

	}

}