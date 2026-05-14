# CHENDY Trading Platform

1/ Proof Of Concept

User logs in
→ sees live market price
→ places buy/sell order
→ system validates balance/holdings
→ order is accepted or rejected
→ order is routed or matched
→ trade is created
→ balance and position are updated
→ user receives notification


1.1 See live market price
  Server:
    `GET /api/markets/{symbol}`:
        API consume: `https://api.binance.com/api/v3/ticker/price?symbol=BTCUSDT`
        
