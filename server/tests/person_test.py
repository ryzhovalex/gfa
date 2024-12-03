from tests.conftest import rpc_json

async def test_get_ok():
    r = await rpc_json("person/get", id=1)
    assert r.id == 1
