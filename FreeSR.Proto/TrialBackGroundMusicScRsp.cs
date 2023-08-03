namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TrialBackGroundMusicScRsp
	{
		[ProtoMember(9)] public int MCDFABFGLEM;
		[ProtoMember(15)] public int Retcode;
	}
	
}
