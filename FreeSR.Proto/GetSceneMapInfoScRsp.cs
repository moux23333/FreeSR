namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetSceneMapInfoScRsp
	{
		[ProtoMember(9)] public int CurMapEntryId;
		[ProtoMember(14)] public List<int> LightenSectionList;
		[ProtoMember(7)] public int EntryId;
		[ProtoMember(6)] public List<DAGBPJHNLAF> UnlockTeleportList;
		[ProtoMember(12)] public bool JIBJCPPHKFI;
		[ProtoMember(4)] public List<AHLJJJNHNPO> KKFJFLAIBPP;
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(5)] public List<int> EMGKEPONFBH;
		[ProtoMember(3)] public List<PAONPGDKOIH> MazeGroupList;
		[ProtoMember(11)] public List<JFLHHNAMPOB> MazePropList;
	}
	
}
