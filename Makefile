all: install

.PHONY: install update
install:
	curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin --version latest
	$(MAKE) update
update:
	sudo apt update
	sudo apt install -uy `cat apt.txt`
