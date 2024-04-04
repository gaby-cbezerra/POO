using System;

string[] hora = Console.ReadLine().Split();
int hInicio = int.Parse(hora[0]);
int mInicio = int.Parse(hora[1]);
int hFim = int.Parse(hora[2]);
int mFim = int.Parse(hora[3]);

int totalH = hFim - hInicio;
int totalM = mFim - mInicio;


if (mFim < mInicio) {
  totalM += 60;
  totalH--;
}


if (totalH < 0) {
  totalH += 24;
}


if (hInicio == hFim && mInicio == mFim) {
  Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
} else {
  Console.WriteLine("O JOGO DUROU " + totalH + " HORA(S) E " + totalM + " MINUTO(S)");
}

