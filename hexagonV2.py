a=int(input("Unesite duzinu stranice : "))
space=" "*(a-1)
spacenum=len(space)
unutrasnjirazmak=2
stars="*"*a
print(space+stars)
for i in range(a-1):
    spacenum-=1
    unutrasnjirazmak+=2
    print(spacenum*" "+"*"+unutrasnjirazmak*" "+ "*")
for i in range(a-2):
    spacenum+=1
    unutrasnjirazmak-=2
    print(spacenum*" "+"*"+unutrasnjirazmak*" "+ "*")
print(space+stars)

#