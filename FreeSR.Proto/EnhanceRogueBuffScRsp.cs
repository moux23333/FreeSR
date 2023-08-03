namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnhanceRogueBuffScRsp
	{
		[ProtoMember(15)] public bool JDLODKGCMIA;
		[ProtoMember(3)] public RogueBuff MazeBuffInfo;
		[ProtoMember(1)] public int Retcode;
	}
	
}
