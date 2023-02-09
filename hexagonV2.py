a=int(input("Enter the side lenght : "))
space=" "*(a-1)
spacenum=len(space)
innerspace=a-2
stars="*"*a
print(space+stars)
for i in range(a-1):
    spacenum-=1
    innerspace+=2
    print(spacenum*" "+"*"+innerspace*" "+ "*")
for i in range(a-2):
    spacenum+=1
    innerspace-=2
    print(spacenum*" "+"*"+innerspace*" "+ "*")
print(space+stars)

#
