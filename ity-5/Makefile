.PHONY: all clean clean-all zip
FILE = proj5
OUT = xchalu15-fit

all: $(FILE).pdf

$(FILE).pdf:
	pdflatex $(FILE).tex
	bibtex $(FILE).aux
	pdflatex $(FILE).tex
	pdflatex $(FILE).tex
zip:
	zip $(OUT) $(FILE).tex Makefile $(FILE).bib czechiso.bst *.png

clean:
	rm -f $(FILE).aux $(FILE).dvi $(FILE).ps $(FILE).log $(FILE).bbl $(FILE).blg $(FILE).blg $(FILE).nav $(FILE).out $(FILE).toc $(FILE).vrb $(FILE).snm

clean-all: clean
	rm -f $(FILE).pdf
