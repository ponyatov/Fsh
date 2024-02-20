# dir
NET = ${HOME}/.dotnet/tools

# tool
DOTNET = $(NET)/dotnet

all: install

.PHONY: install update
install: $(DOTNET)
	$(MAKE) update
update:
	sudo apt update
	sudo apt install -uy `cat apt.txt`

$(DOTNET):
	curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin --version latest
	touch $@
