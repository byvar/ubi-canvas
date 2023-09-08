using System.Linq;
using UbiArt.ITF;

namespace UbiArt.Engine3D {
	// See: ITF::Mesh3D::serialize
	// m3d.ckd file
	public class Mesh3D : CSerializable {
		public const uint VersionLegends = 5;

		public uint Version { get; set; }
		public Link MeshID { get; set; }
		public CListO<Vec3d> Vertices { get; set; }
		public CListO<Vec3d> Normals { get; set; }
		public CListO<Vec2d> UVs { get; set; }
		public CListO<Mesh3D.Element> Elements { get; set; }
		public CListO<Mesh3D.VertexUV> VertexUVs { get; set; }
		public CListO<Mesh3D.SkinElement> SkinElements { get; set; }


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Version = s.Serialize<uint>(Version, name: nameof(Version));
			MeshID = s.SerializeObject<Link>(MeshID, name: nameof(MeshID));

			Vertices = s.SerializeObject<CListO<Vec3d>>(Vertices, name: nameof(Vertices));
			Normals = s.SerializeObject<CListO<Vec3d>>(Normals, name: nameof(Normals));
			UVs = s.SerializeObject<CListO<Vec2d>>(UVs, name: nameof(UVs));
			Elements = s.SerializeObject<CListO<Mesh3D.Element>>(Elements, name: nameof(Elements));
			VertexUVs = s.SerializeObject<CListO<Mesh3D.VertexUV>>(VertexUVs, name: nameof(VertexUVs));
			SkinElements = s.SerializeObject<CListO<Mesh3D.SkinElement>>(SkinElements, name: nameof(SkinElements));
		}

		public class Element : CSerializable {
			public uint MaterialIndex { get; set; }
			public CListO<Mesh3D.Triangle> Triangles { get; set; }

			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				MaterialIndex = s.Serialize<uint>(MaterialIndex, name: nameof(MaterialIndex));
				Triangles = s.SerializeObject<CListO<Triangle>>(Triangles, name: nameof(Triangles));
			}
		}

		public class Triangle : CSerializable {
			public Mesh3D.TripleIndex Vertex { get; set; }
			public Mesh3D.TripleIndex Normal { get; set; }
			public Mesh3D.TripleIndex UV1 { get; set; }
			public Mesh3D.TripleIndex UV2 { get; set; }

			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Vertex = s.SerializeObject<Mesh3D.TripleIndex>(Vertex, name: nameof(Vertex));
				Normal = s.SerializeObject<Mesh3D.TripleIndex>(Normal, name: nameof(Normal));
				UV1 = s.SerializeObject<Mesh3D.TripleIndex>(UV1, name: nameof(UV1));
				UV2 = s.SerializeObject<Mesh3D.TripleIndex>(UV2, name: nameof(UV2));
			}
		}

		public class TripleIndex : CSerializable {
			public uint Index0 { get; set; }
			public uint Index1 { get; set; }
			public uint Index2 { get; set; }

			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Index0 = s.Serialize<uint>(Index0, name: nameof(Index0));
				Index1 = s.Serialize<uint>(Index1, name: nameof(Index1));
				Index2 = s.Serialize<uint>(Index2, name: nameof(Index2));
			}
		}

		public class IndexWeight : CSerializable {
			public uint Index { get; set; }
			public float Weight { get; set; }

			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Index = s.Serialize<uint>(Index, name: nameof(Index));
				Weight = s.Serialize<float>(Weight, name: nameof(Weight));
			}
		}

		public class VertexUV : CSerializable {
			public uint Vertex { get; set; }
			public uint UV { get; set; }

			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Vertex = s.Serialize<uint>(Vertex, name: nameof(Vertex));
				UV = s.Serialize<uint>(UV, name: nameof(UV));
			}
		}

		public class SkinElement : CSerializable {
			public uint ID { get; set; }
			public StringID Name { get; set; }
			public Matrix44 Matrix { get; set; }
			public CListO<Mesh3D.IndexWeight> Weights { get; set; }

			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				ID = s.Serialize<uint>(ID, name: nameof(ID));
				Name = s.SerializeObject<StringID>(Name, name: nameof(Name));
				Matrix = s.SerializeObject<Matrix44>(Matrix, name: nameof(Matrix));
				Weights = s.SerializeObject<CListO<Mesh3D.IndexWeight>>(Weights, name: nameof(Weights));
			}
		}

		public void Reinit(Settings settings) {
			if (settings.Game == Game.RL && Version >= VersionLegends) {
				Version = VersionLegends;
			}
		}
		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Settings);
		}
	}
}
