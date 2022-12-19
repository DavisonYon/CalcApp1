using System;

public class Calculator
{
	public Calculator()
	{
	}

	public float Add(params float[] numbers)
	{
        float answer = 0;
        foreach (float number in numbers)
        {
            answer += number;
        }
		return answer;
	}
    public float Subtract(params float[] numbers)
    {
        float answer = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            answer -= numbers[i];
        }
        return answer;
    }

    public float Multiply(params float[] numbers)
    {
        float answer = 1;
        foreach (float number in numbers)
        {
            answer *= number;
        }
        return answer;
    }

    public float Divide(float a, float b)
    {
        float answer = a / b;
        return answer;
    }
}
