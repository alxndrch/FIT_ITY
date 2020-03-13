.PHONY: all clean clean-all zip
FILE = proj2
OUT = xchalu15-fit

all: $(FILE).pdf

$(FILE).pdf: $(FILE).ps
	ps2pdf $^

$(FILE).ps: $(FILE).dvi
	dvips $^

$(FILE).dvi:
	latex $(FILE).tex
	latex $(FILE).tex

zip:
	zip $(OUT) $(FILE).tex Makefile

clean:
	rm -f $(FILE).aux $(FILE).dvi $(FILE).ps $(FILE).log

clean-all: clean
	rm -f $(FILE).pdf
