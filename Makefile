# version
NET_VER = 8.0.201

# dir
NET = ${HOME}/.dotnet
DISTR = $(HOME)/distr/shared

# tool
DOTNET = $(NET)/dotnet

# all
.PHONY: all
all: install

# install
.PHONY: install update
install: $(DOTNET)
	$(MAKE) update
update:
	sudo apt update
	sudo apt install -uy `cat apt.txt`

$(DOTNET):
	curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin \
		--version latest --verbose --version "$(NET_VER)" \
		--install-dir "$(NET)" \
		--runtime dotnet \
		--keep-zip --zip-path $(DISTR)/SDK/dotnet-runtime-$(NET_VER)-linux-x64.tar.gz \
		--dry-run 
# --dry-run
# touch $@
