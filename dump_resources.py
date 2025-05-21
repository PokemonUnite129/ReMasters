from pathlib import Path
import logging
from dataclasses import dataclass
from typing import Dict

# Default locations matching the C# console application.
UNPACKED_APK_PATH = r"E:\ReallyNeedHelp\PkmMaster\MastersEX"
DOWNLOAD_PATH = r"E:\ReallyNeedHelp\PkmMaster\Datamine256\Datamine"
SHARD_PATH = r"E:\ReallyNeedHelp\PkmMaster\Datamine256\Datamine\assetdb_shard"
OUTPUT_PATH = r"E:\ReallyNeedHelp\PkmMaster\Datamine25600"

@dataclass
class ResourceLocationEntry:
    container_name: str

class ABND:
    def __init__(self, data: bytes):
        self.data = data
        # TODO: parse header, decrypt and decompress as needed

    def dump(self, out_path: str):
        """Placeholder for extracting the ABND archive."""
        # In the original C# implementation this method iterates over
        # all files inside the archive, decrypts and decompresses them
        # and writes them to disk. Implementing the entire format is
        # outside the scope of this example, so this function acts as
        # a stub.
        pass

def dump_resources(resource_db: Dict[str, ResourceLocationEntry], download_path: str, out_root: str):
    processed = set()

    for entry in resource_db.values():
        fn = entry.container_name
        if fn in processed:
            continue

        folder = fn[0]
        file_path = Path(download_path) / folder / fn

        if not file_path.is_file():
            logging.debug("Unable to find file (optional?): %s", fn)
            continue

        data = file_path.read_bytes()
        abnd = ABND(data)

        out_path = out_root
        abnd.dump(out_path)

        processed.add(fn)


if __name__ == "__main__":
    logging.basicConfig(level=logging.INFO)
    # In a real scenario the resource_db would be populated from the
    # game's asset shard files. Here we just demonstrate the API with
    # an empty dictionary because implementing ASDB parsing is beyond
    # the scope of this example.
    resource_db: Dict[str, ResourceLocationEntry] = {}

    dump_resources(resource_db, DOWNLOAD_PATH, OUTPUT_PATH)
