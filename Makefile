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
DOTNET = /usr/bin/dotnet

# pkg
NET_GZ = $(DISTR)/SDK/dotnet-runtime-$(NET_VER)-linux-x64.tar.gz
NET_MS  = packages-microsoft-prod.deb
NET_DEB = $(DISTR)/SDK/$(NET_MS)
NET_URL = https://packages.microsoft.com/config/debian/11

# src
F += $(wildcard lib/*.f*)

# all
.PHONY: all
all: $(DOTNET) $(F)
	$(DOTNET) fsi $(F)

# install
.PHONY: install update
install: $(DOTNET)
	$(MAKE) update
update:
	sudo apt update
	sudo apt install -uy `cat apt.txt`

$(DOTNET): $(NET_DEB)
	sudo dpkg -i $< && sudo touch $@
$(NET_DEB):
	$(CURL) $@ $(NET_URL)/$(NET_MS)

# curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin \
# 	--version latest --verbose --version "$(NET_VER)" \
# 	--install-dir "$(NET)" \
# 	--runtime dotnet \
# 	--keep-zip --zip-path $(NET_GZ) --dry-run
# --dry-run
# touch $@
