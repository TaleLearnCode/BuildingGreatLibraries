namespace TaleLearnCode.MathOperationsLibrary
{
	///
	public interface IMathOperations
	{

		/// <summary>
		/// Returns the sum of <paramref name="addend1"/> and <paramref name="addend2"/>.
		/// </summary>
		/// <param name="addend1">The first number to be added.</param>
		/// <param name="addend2">The second number to be added.</param>
		/// <returns>The sum of <paramref name="addend1"/> and <paramref name="addend2"/>.</returns>
		double Add(double addend1, double addend2);

		/// <summary>
		/// Returns the results of removing <paramref name="subtrahend"/> from the <paramref name="minuend"/>.
		/// </summary>
		/// <param name="minuend">: a number from which the subtrahend is to be subtracted</param>
		/// <param name="subtrahend">The number that is to be subtracted from a minuend.</param>
		/// <returns>The results of removing the <paramref name="subtrahend"/> from the <paramref name="minuend"/>.</returns>
		double Subtract(double minuend, double subtrahend);

		/// <summary>
		/// Returns the product of multiplying the <paramref name="multiplicand"/> by the <paramref name="multiplier"/>.
		/// </summary>
		/// <param name="multiplicand">The number that is to be multiplied by the <paramref name="multiplier"/>.</param>
		/// <param name="multiplier">The number by which the <paramref name="multiplicand"/> is multiplied</param>
		/// <returns>The product of multiplying the <paramref name="multiplicand"/> by the <paramref name="multiplier"/>.</returns>
		double Multiply(double multiplicand, double multiplier);

		/// <summary>
		/// Returns the calculation of the number of times one number (<paramref name="dividend"/>) is contained within another (<paramref name="divisor"/>).
		/// </summary>
		/// <param name="dividend">a number to be divided</param>
		/// <param name="divisor">the number by which a dividend is divided</param>
		/// <returns></returns>
		double Divide(double dividend, double divisor);
	}
}