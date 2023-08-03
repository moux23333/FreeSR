namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MotionInfo
	{
		[ProtoMember(2)] public Vector Rot;
		[ProtoMember(12)] public Vector Pos;
	}
	
}
