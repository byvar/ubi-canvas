using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UbiArt.FileFormat {
    public abstract class UbiArtFile : IDisposable {

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="context">The context the file belongs to</param>
		/// <param name="filePath">The file path relative to the main directory in the context</param>
		/// <param name="endianness">The endianness to use when serializing the file</param>
		/// <param name="baseAddress">The base address for the file. If the file is not memory mapped this should be 0.</param>
		/// <param name="startPointer">The start pointer for the file. If null it will be the same as <see cref="BaseAddress"/></param>
		/// <param name="memoryMappedPriority">e file priority if memory mapped. Default is the address if set to -1.</param>
		protected UbiArtFile(Context context, string filePath) {
			Context = context ?? throw new ArgumentNullException(nameof(context));
			FilePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
			FilePath = Context.NormalizePath(FilePath, false);
		}

		#endregion

		#region Abstraction

		protected IFileManager FileManager => Context.FileManager;

		#endregion

		#region Public Properties

		/// <summary>
		/// The context the file belongs to
		/// </summary>
		public Context Context { get; }

		/// <summary>
		/// Files can be identified with an alias besides <see cref="FilePath"/>
		/// </summary>
		public string Alias { get; set; }

		/// <summary>
		/// The file path relative to the main directory in the context
		/// </summary>
		public string FilePath { get; }

		public virtual string DisplayName => Alias ?? FilePath;

		public string Extension {
			get {
				if (FilePath.Contains(".")) {
					return FilePath.Substring(FilePath.LastIndexOf(".") + 1);
				} else return null;
			}
		}
		#endregion

		public CSerializerObject CurrentSerializer { get; protected set; }

        public void Dispose() {
			if(CurrentSerializer != null)
				CurrentSerializer?.Dispose();
			CurrentSerializer = null;
        }

		public abstract CSerializerObject Deserializer { get; }
		public abstract CSerializerObject Serializer { get; }
	}
}
