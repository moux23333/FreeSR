namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetSceneMapInfoScRsp
	{
		[ProtoMember(4)] public List<int> Pejmpfblini;
		[ProtoMember(7)] public List<MazeMapData> MapList;
		[ProtoMember(9)] public int CurMapEntryId;
		[ProtoMember(5)] public List<MazeGroup> MazeGroupList;
		[ProtoMember(10)] public bool Dbhfekhniih;
		[ProtoMember(1)] public List<int> Plhhejpgcnp;
		[ProtoMember(6)] public List<UnlockedTeleportData> UnlockedTeleportList;
		[ProtoMember(12)] public int EntryId;
		[ProtoMember(8)] public int Retcode;
		[ProtoMember(3)] public List<MazeProp> MazePropList;
	}

}
