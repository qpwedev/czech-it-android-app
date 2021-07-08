using System;
namespace CzechIt {
    public class QuestionsClass {
        public static int score = 0;
        public static float totalErrors = 0;
        public static float totalRight = 0;
        public static float totalSkips = 0;

        public static string Text {
            get {
                return @"1;0;D[_]m;ů;c;š;m
2;0;Te[_]a;t;c;č;k
3;0;Mami[_]ka;n;j;m;c
4;0;Tatine[_];k;z;v;h
5;0;[_]oncert;K;J;V;C
6;0;Ki[_]o;n;j;s;ž
7;0;Dopi[_];s;m;p;j
8;0;Š[_]ola;k;r;ř;d
9;0;Js[_]m;e;á;o;i
10;0;Js[_]u;o;á;i;é
11;0;Kr[_]užek;o;ě;i;a
12;0;Č[_]rka;á;y;ý;ě
13;0;Háče[_];k;n;d;c
14;0;Stude[_]t;n;h;d;č
15;0;Dok[_]or;t;p;j;z
16;0;Manaž[_]r;e;á;ě;a
17;0;Su[_]ermarket;p;d;j;z
18;0;V[_]no;í;á;a;i
19;0;Centr[_]m;u;ě;a;é
20;0;Pr[_]blém;o;í;é;e
21;0;[_]ům;D;G;B;Š
22;0;Tet[_];a;e;é;i
23;0;Mamink[_];a;ý;y;e
24;0;Tati[_]ek;n;g;h;z
25;0;Konce[_]t;r;v;f;č
26;0;[_]ino;K;Z;N;Š
27;0;D[_]pis;o;á;y;a
28;0;Jse[_];m;š;č;k
29;0;[_]sou;J;G;V;Z
30;0;Krouž[_]k;e;é;i;a
31;0;Čá[_]ka;r;z;s;j
32;0;[_]áček;H;F;M;Š
33;0;[_]tudent;S;P;M;L
34;0;[_]oktor;D;H;T;G
35;0;Man[_]žer;a;é;u;y
36;0;S[_]permarket;u;ý;í;y
37;0;Ví[_]o;n;h;j;ž
38;0;C[_]ntrum;e;y;é;a
39;0;P[_]oblém;r;m;b;č
40;1;Velký [___];dům;krásná;jeden;abeceda
41;1;Dej [__] to;mi;to;syn;v
42;1;[___] tam byl?;Kdo;Mi;Republika;Byl?
43;1;[_____] abeceda;Česká;To;Dům;Dej
44;1;[_____] háček;Jeden;Republika;Česká;Je
45;1;[_____] čárka;Jedna;Republika;Byt;V
46;1;Můj [___];byt;v;krásná;můj
47;1;To je můj [___];syn;to;čeština;abeceda
48;1;V [_____];Praze;byt;čárka;syn
49;1;Česká [_________];republika;pivo?;je;syn
50;1;Krásná [_______];čeština;to;byl?;v
51;1;[____] pivo?;Máte;Krásná;Jedna;Je
52;1;[_____] dům;Velký;Dům;Syn;Abeceda
53;1;Jeden [_____];háček;abeceda;máte;velká
54;1;Jedna [_____];čárka;velký;syn;dej
55;1;To [__] můj syn;je;čárka;to;česká
56;1;[_] Praze;V;Byl?;Tam;Republika
57;1;[_____] republika;Česká;Dej;Máte;Dům
58;1;[______] čeština;Krásná;Můj;Jeden;Velký
59;1;Máte [_____];pivo?;dej;republika;můj
60;1;Kdo tam [____];byl?;dům;krásná;je
61;1;Česká [_______];abeceda;to;dům;čeština
62;1;[___] byt;Můj;Byl?;Česká;Praze
63;1;To je [___] syn;můj;háček;byt;to
64;1;[___] mi to;Dej;Byl?;Byt;Abeceda
65;1;Kdo [___] byl?;tam;v;byt;česká
66;1;[__] je můj syn;To;Jedna;Čárka;Je
67;1;Dej mi [__];to;česká;krásná;pivo?
68;2;Дом;Dům;Centrum;Koncert;Čárka
69;2;Папа;Tatinek;Student;Háček;Chléb
70;2;Мама;Maminka;Strom;Víno;Chléb
71;2;Дерево;Strom;Koncert;Centrum;Tatinek
72;2;Хлеб;Chléb;Háček;Škola;Dopis
73;2;Птица;Pták;Centrum;Strom;Problém
74;2;Концерт;Koncert;Kino;Kroužek;Dopis
75;2;Кино;Kino;Víno;Čeština;Háček
76;2;Письмо;Dopis;Škola;Čeština;Tatinek
77;2;Школа;Škola;Dům;Háček;Koncert
78;2;Кружок;Kroužek;Škola;Dopis;Manažer
79;2;Черточка (запятая);Čárka;Kroužek;Centrum;Maminka
80;2;Крючек;Háček;Chléb;Manažer;Kroužek
81;2;Студент;Student;Maminka;Háček;Tatinek
82;2;Доктор;Doktor;Supermarket;Dopis;Škola
83;2;Менеджер;Manažer;Pták;Víno;Centrum
84;2;Супермаркет;Supermarket;Student;Kroužek;Dopis
85;2;Вино;Víno;Koncert;Doktor;Chléb
86;2;Центр;Centrum;Tatinek;Dopis;Kino
87;2;Проблема;Problém;Maminka;Čárka;Škola
88;2;Чешский язык;Čeština;Dům;Pták;Víno
89;2;Dům;Дом;Проблема;Менеджер;Центр
90;2;Tatinek;Папа;Дерево;Концерт;Школа
91;2;Maminka;Мама;Черточка (запятая);Студент;Супермаркет
92;2;Strom;Дерево;Проблема;Черточка (запятая);Папа
93;2;Chléb;Хлеб;Письмо;Супермаркет;Чешский язык
94;2;Pták;Птица;Концерт;Хлеб;Дом
95;2;Koncert;Концерт;Мама;Дом;Черточка (запятая)
96;2;Kino;Кино;Кружок;Школа;Чешский язык
97;2;Dopis;Письмо;Черточка (запятая);Проблема;Менеджер
98;2;Škola;Школа;Дерево;Студент;Доктор
99;2;Kroužek;Кружок;Дом;Центр;Дерево
100;2;Čárka;Черточка (запятая);Папа;Дерево;Чешский язык
101;2;Háček;Крючек;Чешский язык;Доктор;Студент
102;2;Student;Студент;Дерево;Мама;Вино
103;2;Doktor;Доктор;Кружок;Папа;Письмо
104;2;Manažer;Менеджер;Чешский язык;Центр;Супермаркет
105;2;Supermarket;Супермаркет;Вино;Черточка (запятая);Концерт
106;2;Víno;Вино;Папа;Студент;Супермаркет
107;2;Centrum;Центр;Хлеб;Чешский язык;Студент
108;2;Problém;Проблема;Кино;Папа;Концерт
109;2;Čeština;Чешский язык;Крючек;Студент;Дом";
            }
        }
    }
}
