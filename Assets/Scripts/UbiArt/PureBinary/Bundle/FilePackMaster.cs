using UbiArt.FileFormat.Texture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Bundle {
	public class FilePackMaster : ICSerializable {
		public CList<Pair<FileHeaderRuntime, Path>> files;

		public void Serialize(CSerializerObject s, string name) {
			files = s.SerializeObject<CList<Pair<FileHeaderRuntime, Path>>>(files);
		}

		public FilePackMaster() {
			files = new CList<Pair<FileHeaderRuntime, Path>>();
		}
	}
}
