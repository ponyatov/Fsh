# var
MODULE  = $(notdir $(CURDIR))

# version
NET_VER = 8.0.201

# dir
CWD   = $(CURDIR)
NET   = $(HOME)/.dotnet
DISTR = $(HOME)/distr/shared

# tool
CURL   = curl -L -o
DOTNET = $(NET)/dotnet

# pkg
NET_GZ = $(DISTR)/SDK/dotnet-runtime-$(NET_VER)-linux-x64.tar.gz
NET_DEB = $(DISTR)/SDK/packages-microsoft-prod.deb

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

$(DOTNET): $(NET_DEB)
	sudo dpkg -i $<
$(NET_DEB):
	$(CURL) $@ https://packages.microsoft.com/config/debian/11/packages-microsoft-prod.deb

# curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin \
# 	--version latest --verbose --version "$(NET_VER)" \
# 	--install-dir "$(NET)" \
# 	--runtime dotnet \
# 	--keep-zip --zip-path $(NET_GZ) --dry-run
# --dry-run
# touch $@
