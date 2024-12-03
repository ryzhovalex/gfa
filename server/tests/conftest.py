from typing import Any, Iterable
import httpx

URL = "http://localhost:3000/rpc"

async def rpc_json(target: str, **body_kwargs) -> Any:
    r = await httpx.AsyncClient().post(URL + "/" + target, json=body_kwargs)
    assert r.status_code in [200, 400]
    return r.json()
