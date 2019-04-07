using UbiArt.FileFormat.Texture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Bundle {
	public class BundleFile : ICSerializable {
		public BundleBootHeader bootHeader;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref bootHeader);
		}
	}
}
