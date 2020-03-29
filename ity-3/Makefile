.PHONY: all clean clean-all zip
FILE = proj3
OUT = xchalu15-fit

all: $(FILE).pdf

$(FILE).pdf: $(FILE).ps
	ps2pdf -sPAPERSIZE=a4 $^

$(FILE).ps: $(FILE).dvi
	dvips $^

$(FILE).dvi:
	latex $(FILE).tex
	latex $(FILE).tex

zip:
	zip $(OUT) $(FILE).tex Makefile oniisan.eps oniisan2.eps etiopan.eps

clean:
	rm -f $(FILE).aux $(FILE).dvi $(FILE).ps $(FILE).log

clean-all: clean
	rm -f $(FILE).pdf
