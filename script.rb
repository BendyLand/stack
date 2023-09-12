require './stack.rb'

lst = Stack.new

lst.push("Ben")
lst.push("Olivia")
lst.push("Reese")
lst.push("Puff")

puts lst.peek()

lst.pop()

puts lst.peek()