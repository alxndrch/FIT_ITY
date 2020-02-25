Z�kladn� informace o dokumentu
------------------------------
rozm�ry str�nky: A4
rozm�ry textov� oblasti: 17x23cm
mezera vlevo: 2cm
mezera naho�e: 2cm
font: standardn� 10pt (vzorov� dokument pou��v� k�dov�n� font� T1)
sazba na dva sloupce: parametr 'twocolumn' dokumentov� t��dy 'article'

Up�esn�n�
---------

- Poml�ky a spojovn�ky jsou v tomto textu zad�ny znakem -. V dokumentu mus� b�t spr�vn� ���ka poml�ek, spojovn�k� a mezer podle kontextu.
- V tomto textu jsou pou�ity tyto "dvojit� uvozovky". Ve v�sledn�m dokumentu mus� b�t uvozovky podle zadan�ho PDF (kdy� nepou�ijete UTF-8, �e�te �esk� uvozovky pomoc� p�eddefinovan�ho p��kazu).
- Adresy (email, http) v tomto textu mus� b�t vys�zen� speci�n�mi p��kazy k tomu ur�en�mi.

- Vzorov� dokument byl vys�zen LaTeXem t�mito n�stroji:
  latex
  dvips -t a4
  ps2pdf
  
  P�i pou�it� pdflatexu je v�sledn� soubor vizu�ln� toto�n�, ale je dvakr�t v�t��.

Text dokumentu
--------------

Typografie a publikov�n� - 1. projekt
VA�E JM�NO (xloginNN@stud.fit.vutbr.cz)


Hladk� sazba

Hladk� sazba pou��v� jeden stupe�, druh a �ez p�sma a je s�zena na stanovenou ���ku odstavce. Skl�d� se z odstavc�, obvykle za��naj�c�ch zar�kou, nejde-li o prvn� odstavec za nadpisem. Mohou ale b�t s�zeny i bez zar�ky - rozhoduj�c� je celkov� grafick� �prava. Odstavec kon�� v�chodovou ��dkou. V�ty nesm�j� za��nat ��slic�.

Zv�razn�n� barvou, podtr�en�m, ani zm�nou p�sma se v odstavc�ch nepou��v�. Hladk� sazba je ur�ena p�edev��m pro del�� texty, jako je beletrie. Poru�en� konzistence sazby p�sob� v textu ru�iv� a unavuje �ten���v zrak.

Sm�en� sazba

Sm�en� sazba m� o n�co voln�j�� pravidla. Klasick� hladk� sazba se dopl�uje o dal�� �ezy p�sma pro zv�razn�n� d�le�it�ch pojm�. Existuje "pravidlo":

��m v�ce druh�, �ez�, velikost�, barev p�sma a jin�ch efekt� pou�ijeme, t�m profesion�ln�ji bude dokument vypadat. �ten�� t�m bude v�dy nad�en!

T�mto pravidlem se nikdy nesm�te ��dit. P��li� �ast� zv�raz�ov�n� textov�ch element� a zm�ny velikosti p�sma jsou zn�mkou amat�rismu autora a p�sob� velmi ru�iv�. Dob�e navr�en� dokument nem� obsahovat v�ce ne�
4 �ezy �i druhy p�sma. Dob�e navr�en� dokument je decentn�, ne chaotick�.

D�le�it�m znakem spr�vn� vys�zen�ho dokumentu je konzistence - nap��klad tu�n� �ez p�sma bude vyhrazen pouze pro kl��ov� slova, sklon�n� �ez pouze pro doposud nezn�m� pojmy a nebude se to m�chat. Sklon�n� �ez nep�sob� tak ru�iv� a pou��v� se �ast�ji. V LaTeXu jej s�z�me rad�ji p��kazem \emph{text} ne� \textit{text}.

Sm�en� sazba se nej�ast�ji pou��v� pro sazbu v�deck�ch �l�nk� a technick�ch zpr�v. U del��ch dokument� v�deck�ho �i technick�ho charakteru je zvykem vysv�tlit v�znam r�zn�ch typ� zv�razn�n� v �vodn� kapitole.


�esk� odli�nosti

�esk� sazba se oproti okoln�mu sv�tu v n�kter�ch aspektech m�rn� li��. Jednou z odli�nost� je sazba uvozovek. Uvozovky se v �e�tin� pou��vaj� p�ev�n� pro zobrazen� p��m� �e�i, zv�razn�n� p�ezd�vek a ironie. V �e�tin� se pou��vaj� uvozovky typu "9966" m�sto "anglick�ch" uvozovek nebo "dvojit�ch" uvozovek. Lze je s�zet p�ipraven�mi p��kazy nebo p�i pou�it� UTF-8 k�dov�n� i p��mo.

Ve sm�en� sazb� se �ez uvozovek ��d� �ezem prvn�ho uvozovan�ho slova. Pokud je uvozov�na cel� v�ta, s�z� se koncov� te�ka p�ed uvozovku, pokud se uvozuje slovo nebo ��st v�ty, s�z� se te�ka za uvozovku.

Druhou odli�nost� je pravidlo pro s�zen� konc� ��dk�. V �esk� sazb� by ��dek nem�l kon�it osamocenou jednop�smennou p�edlo�kou nebo spojkou. Spojkou "a" kon�it m��e pouze p�i sazb� do ���ky 25 liter. Abychom LaTeXu zabr�nili v s�zen� osamocen�ch p�edlo�ek, spojujeme je s n�sleduj�c�m slovem nezlomitelnou mezerou. Tu s�z�me pomoc� znaku ~ (vlnka, tilda). Pro systematick� dopln�n� vlnek slou�� voln� �i�iteln� program vlna od pana Ol��ka.

Bal��ek fontenc slou�� ke korektn�mu k�dovan� znak� s diakritikou, aby bylo mo�no v textu vyhled�vat a kop�rovat z n�j.

Z�v�r

Tento dokument je �len�n na sekce pomoc� p��kazu \section. Jedna ze sekc� schv�ln� obsahuje n�kolik typografick�ch proh�e�k�. V kontextu cel�ho textu je jist� snadno najdete. Je dobr� zn�t mo�nosti LaTeXu, ale je tak� nutn� v�d�t, kdy je nepou��t.

---
1 Viz http://petr.olsak.net/ftp/olsak/vlna/
2 P��li� mnoho pozn�mek pod �arou �ten��e zbyte�n� rozptyluje. Pou��vejte je opravdu st��dm�. (�et�ete i s textem v z�vork�ch.)

