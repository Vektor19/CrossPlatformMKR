using CrossPlatformMKR;

string inputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\INPUT.txt");
string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\OUTPUT.txt");
string[] inputValues = Utils.ReadInput(inputPath);
string[] solutions = new string[inputValues.Length];

for (int i = 0; i < inputValues.Length; i++)
{
    if (!Utils.isInputValid(inputValues[i])) solutions[i] = "Bad input";
    else solutions[i] = TaskSolver.SolveTask(inputValues[i]).ToString();
}
Utils.WriteResult(outputPath, solutions);
Console.WriteLine("Done! Check the OUTPUT.txt file for the results.");