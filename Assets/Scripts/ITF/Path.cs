using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF {
	public class Path {
		public string folder;
		public string filename;
		public StringID stringID;
		public uint unk;
		public Path(Reader reader) {
			// null path: 0, 0, -1, 0
			folder = reader.ReadString();
			filename = reader.ReadString();
			stringID = new StringID(reader);
			unk = reader.ReadUInt32();
		}

		public Path(string folder, string filename) {
			folder = folder.Replace('\\', '/');
			if (folder != null && folder != "" && !folder.EndsWith("/")) folder += "/";
			if (folder != null && folder.StartsWith("/")) folder = folder.Substring(1);
			if (filename != null && filename.EndsWith(".ckd")) filename = filename.Substring(0, filename.Length - 4);
			this.folder = folder;
			this.filename = filename;
			if ((folder != null && folder != "") || (filename != null && filename != "")) {
				stringID = new StringID(FullPath);
			} else {
				stringID = new StringID();
			}
		}

		public string FullPath {
			get {
				return (folder ?? "") + (filename ?? "");
			}
		}

		public bool IsNull {
			get {
				return ((folder == null || folder == "") && (filename == null || filename == "") && stringID.IsNull);
			}
		}
	}
}
