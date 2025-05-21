# ReMasters
Reverse Engineering of Pokémon Masters

![License](https://img.shields.io/badge/License-GPLv3-blue.svg)

### Usage:

In `Program.cs`:
- Change the path variables to point to your unpacked & downloaded files.
- Specify the output path.

`dump_resources.py` contains a minimal Python reimplementation of the resource
extraction loop. The default paths at the top of the script mirror those in
`Program.cs`. This Python version does not implement ABND decryption or
decompression and is provided purely as a starting point.

When the Console project is run the program will decrypt, decompress, and export as much content as possible.

### Credits:

By [SciresM](https://github.com/SciresM/) &amp; [Kaphotics](https://github.com/kwsch/)
