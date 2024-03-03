# var
MODULE  = $(notdir $(CURDIR))

# version
NET_VER = 8.0.200

# dir
CWD   = $(CURDIR)
NET   = $(HOME)/.dotnet
DISTR = $(HOME)/distr

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
C += $(wildcard src/*.c*)
H += $(wildcard inc/*.h*)

F = lib/Program.fs lib/Object.fs

# all
.PHONY: all
FSX = $(addprefix --load:, $(F))
all: $(DOTNET) $(F)
	$(DOTNET) fsi --consolecolors+ $(FSX)

# format
.PHONY: format
format: tmp/format_f
tmp/format_f: $(F)
	$(DOTNET) fantomas --force $? && touch $@

# doc
.PHONY: doc
doc: \
	doc/Chris_Smith_Programming_F.pdf

doc/Chris_Smith_Programming_F.pdf:
	$(CURL) $@ https://books-library.net/files/books-library.net-10251730Wq5A3.pdf

# install
.PHONY: install update
install: $(DOTNET) doc
	$(MAKE) update
# $(DOTNET) new  tool-manifest
# $(DOTNET) tool install fantomas
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
