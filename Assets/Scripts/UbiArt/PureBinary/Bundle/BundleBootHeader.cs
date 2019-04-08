using UbiArt.FileFormat.Texture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Bundle {
	public class BundleBootHeader : ICSerializable {
		public static uint staticSignature = 0x50EC12BA;
		public uint signature = staticSignature;
		public uint unk0;
		public uint unk1;
		public uint baseOffset;
		public uint numFiles;
		public bool unk2;
		public bool unk3;
		public bool unk4;
		public uint unk5;
		public uint unk6;
		public uint unk7;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref signature);
			s.Serialize(ref unk0);
			s.Serialize(ref unk1);
			s.Serialize(ref baseOffset);
			s.Serialize(ref numFiles);
			s.Serialize(ref unk2);
			s.Serialize(ref unk3);
			s.Serialize(ref unk4);
			s.Serialize(ref unk5);
			s.Serialize(ref unk6);
			s.Serialize(ref unk7);
		}

		public BundleBootHeader() {
			if (Settings.s.game == Settings.Game.RL) {
				signature = staticSignature;
				unk0 = 5;
				unk1 = 0;
				unk2 = false;
				unk3 = true;
				unk4 = true;
				unk5 = 0;
				unk6 = 0x4BFC7C03;
				unk7 = 0;
			}
		}
	}
}
