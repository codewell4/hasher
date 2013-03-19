hasher
======

Calculate hashes (CRC,MD5,SHA1) for files, directories and batch files

I wanted a tool similar to Total Commander's create checksum. But I wanted to do it in a batch.
Since I didn't find suitable program, I've made one myself.

###Status
This is a really dirty version of program. I've made it so it works, but no exception handling
and also all functions were not tested.

You can select to do a checksum of file. Or checksum of directory which you can save to file.
You also have possibility of making batch checksum of directories/files specified in batch
file (entries of directory/files should be divided by CRLF).

###TODO
- Exception handling
- Checksum for every file in directory
- Save checksum to file in file mode
- Command line mode
