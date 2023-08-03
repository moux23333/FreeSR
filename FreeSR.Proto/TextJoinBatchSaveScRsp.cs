namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TextJoinBatchSaveScRsp
	{
		[ProtoMember(6)] public int Retcode;
		[ProtoMember(3)] public List<PAIFIBFIGBG> GHEEIMLLGHD;
	}
	
}
