using static Library;

int numberM = InputNumbers("Введите M: ");
int numberN = InputNumbers("Введите N: ");
int temp = numberM;

if (numberM > numberN)
{
  numberM = numberN;
  numberN = temp;
}

PrintSumm(numberM, numberN, temp = 0);
