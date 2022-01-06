Program Add(input, output); {add three numbers}
Uses crt; {standard Pascal library}
Var
  number_1, number_2, number_3, total: String;
Begin
  Writeln('Enter first number');
  Readln(number_1);
  Writeln('Enter second number');
  Readln(number_2);
  Writeln('Enter third number');
  Readln(number_3);
  total := number_1 + number_2 + number_3;
  Writeln('The total is ', total);
End.