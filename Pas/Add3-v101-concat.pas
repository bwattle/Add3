Program Add(input, output); {add three numbers}
Uses crt; {standard Pascal library}
Var
  number_1, number_2, number_3, total: String;      {declarations}
Begin
  Writeln('v1.01 Add3. You will be asked for 3 numbers:'); {version}
  Writeln('Enter first number:');                  {read user inputs}
  Readln(number_1);
  Writeln('Enter second number:');
  Readln(number_2);
  Writeln('Enter third number:');
  Readln(number_3);
  total := number_1 + number_2 + number_3;          {assignment}
  Writeln('The total is ', total);                  {dispaly}
End.