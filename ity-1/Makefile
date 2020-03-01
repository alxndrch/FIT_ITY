.PHONY: all clean clean-all
FILE = test

all: $(FILE).pdf

$(FILE).pdf: $(FILE).ps
	ps2pdf $^

$(FILE).ps: $(FILE).dvi
	dvips $^

$(FILE).dvi:
	latex $(FILE).tex

clean:
	rm -f $(FILE).aux $(FILE).dvi $(FILE).ps $(FILE).log

clean-all: clean
	rm -f $(FILE).pdf
