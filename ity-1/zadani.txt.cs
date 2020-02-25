Základní informace o dokumentu
------------------------------
rozmìry stránky: A4
rozmìry textové oblasti: 17x23cm
mezera vlevo: 2cm
mezera nahoøe: 2cm
font: standardní 10pt (vzorový dokument pou¾ívá kódování fontù T1)
sazba na dva sloupce: parametr 'twocolumn' dokumentové tøídy 'article'

Upøesnìní
---------

- Pomlèky a spojovníky jsou v tomto textu zadány znakem -. V dokumentu musí být správná ¹íøka pomlèek, spojovníkù a mezer podle kontextu.
- V tomto textu jsou pou¾ity tyto "dvojité uvozovky". Ve výsledném dokumentu musí být uvozovky podle zadaného PDF (kdy¾ nepou¾ijete UTF-8, øe¹te èeské uvozovky pomocí pøeddefinovaného pøíkazu).
- Adresy (email, http) v tomto textu musí být vysázená speciáními pøíkazy k tomu urèenými.

- Vzorový dokument byl vysázen LaTeXem tìmito nástroji:
  latex
  dvips -t a4
  ps2pdf
  
  Pøi pou¾ití pdflatexu je výsledný soubor vizuálnì toto¾ný, ale je dvakrát vìt¹í.

Text dokumentu
--------------

Typografie a publikování - 1. projekt
VA©E JMÉNO (xloginNN@stud.fit.vutbr.cz)


Hladká sazba

Hladká sazba pou¾ívá jeden stupeò, druh a øez písma a je sázena na stanovenou ¹íøku odstavce. Skládá se z odstavcù, obvykle zaèínajících zará¾kou, nejde-li o první odstavec za nadpisem. Mohou ale být sázeny i bez zará¾ky - rozhodující je celková grafická úprava. Odstavec konèí východovou øádkou. Vìty nesmìjí zaèínat èíslicí.

Zvýraznìní barvou, podtr¾ením, ani zmìnou písma se v odstavcích nepou¾ívá. Hladká sazba je urèena pøedev¹ím pro del¹í texty, jako je beletrie. Poru¹ení konzistence sazby pùsobí v textu ru¹ivì a unavuje ètenáøùv zrak.

Smí¹ená sazba

Smí¹ená sazba má o nìco volnìj¹í pravidla. Klasická hladká sazba se doplòuje o dal¹í øezy písma pro zvýraznìní dùle¾itých pojmù. Existuje "pravidlo":

Èím více druhù, øezù, velikostí, barev písma a jiných efektù pou¾ijeme, tím profesionálnìji bude dokument vypadat. Ètenáø tím bude v¾dy nad¹en!

Tímto pravidlem se nikdy nesmíte øídit. Pøíli¹ èasté zvýrazòování textových elementù a zmìny velikosti písma jsou známkou amatérismu autora a pùsobí velmi ru¹ivì. Dobøe navr¾ený dokument nemá obsahovat více ne¾
4 øezy èi druhy písma. Dobøe navr¾ený dokument je decentní, ne chaotický.

Dùle¾itým znakem správnì vysázeného dokumentu je konzistence - napøíklad tuèný øez písma bude vyhrazen pouze pro klíèová slova, sklonìný øez pouze pro doposud neznámé pojmy a nebude se to míchat. Sklonìný øez nepùsobí tak ru¹ivì a pou¾ívá se èastìji. V LaTeXu jej sázíme radìji pøíkazem \emph{text} ne¾ \textit{text}.

Smí¹ená sazba se nejèastìji pou¾ívá pro sazbu vìdeckých èlánkù a technických zpráv. U del¹ích dokumentù vìdeckého èi technického charakteru je zvykem vysvìtlit význam rùzných typù zvýraznìní v úvodní kapitole.


Èeské odli¹nosti

Èeská sazba se oproti okolnímu svìtu v nìkterých aspektech mírnì li¹í. Jednou z odli¹ností je sazba uvozovek. Uvozovky se v èe¹tinì pou¾ívají pøevá¾nì pro zobrazení pøímé øeèi, zvýraznìní pøezdívek a ironie. V èe¹tinì se pou¾ívají uvozovky typu "9966" místo "anglických" uvozovek nebo "dvojitých" uvozovek. Lze je sázet pøipravenými pøíkazy nebo pøi pou¾ití UTF-8 kódování i pøímo.

Ve smí¹ené sazbì se øez uvozovek øídí øezem prvního uvozovaného slova. Pokud je uvozována celá vìta, sází se koncová teèka pøed uvozovku, pokud se uvozuje slovo nebo èást vìty, sází se teèka za uvozovku.

Druhou odli¹ností je pravidlo pro sázení koncù øádkù. V èeské sazbì by øádek nemìl konèit osamocenou jednopísmennou pøedlo¾kou nebo spojkou. Spojkou "a" konèit mù¾e pouze pøi sazbì do ¹íøky 25 liter. Abychom LaTeXu zabránili v sázení osamocených pøedlo¾ek, spojujeme je s následujícím slovem nezlomitelnou mezerou. Tu sázíme pomocí znaku ~ (vlnka, tilda). Pro systematické doplnìní vlnek slou¾í volnì ¹iøitelný program vlna od pana Ol¹áka.

Balíèek fontenc slou¾í ke korektnímu kódovaní znakù s diakritikou, aby bylo mo¾no v textu vyhledávat a kopírovat z nìj.

Závìr

Tento dokument je èlenìn na sekce pomocí pøíkazu \section. Jedna ze sekcí schválnì obsahuje nìkolik typografických prohøe¹kù. V kontextu celého textu je jistì snadno najdete. Je dobré znát mo¾nosti LaTeXu, ale je také nutné vìdìt, kdy je nepou¾ít.

---
1 Viz http://petr.olsak.net/ftp/olsak/vlna/
2 Pøíli¹ mnoho poznámek pod èarou ètenáøe zbyteènì rozptyluje. Pou¾ívejte je opravdu støídmì. (©etøete i s textem v závorkách.)

