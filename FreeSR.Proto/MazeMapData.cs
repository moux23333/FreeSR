namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MazeMapData
	{
		[ProtoMember(13)] public int CurMapEntryId;
		[ProtoMember(8)] public List<int> Plhhejpgcnp;
		[ProtoMember(3)] public int Retcode;
		[ProtoMember(14)] public int EntryId;
		[ProtoMember(2)] public List<int> Pejmpfblini;
		[ProtoMember(5)] public List<MazeGroup> MazeGroupList;
		[ProtoMember(1)] public List<UnlockedTeleportData> UnlockedTeleportList;
		[ProtoMember(7)] public List<MazeProp> MazePropList;
	}

}
