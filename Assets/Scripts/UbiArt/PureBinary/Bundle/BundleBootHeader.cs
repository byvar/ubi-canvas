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
			signature = s.Serialize<uint>(signature, name: nameof(signature));
			unk0 = s.Serialize<uint>(unk0, name: nameof(unk0));
			unk1 = s.Serialize<uint>(unk1, name: nameof(unk1));
			baseOffset = s.Serialize<uint>(baseOffset, name: nameof(baseOffset));
			numFiles = s.Serialize<uint>(numFiles, name: nameof(numFiles));
			unk2 = s.Serialize<bool>(unk2, name: nameof(unk2));
			unk3 = s.Serialize<bool>(unk3, name: nameof(unk3));
			unk4 = s.Serialize<bool>(unk4, name: nameof(unk4));
			unk5 = s.Serialize<uint>(unk5, name: nameof(unk5));
			unk6 = s.Serialize<uint>(unk6, name: nameof(unk6));
			unk7 = s.Serialize<uint>(unk7, name: nameof(unk7));
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
